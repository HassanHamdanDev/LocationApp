import { useEffect, useState } from 'react';
import LocationService, { Coordinates } from '../services/LocationService';
import { checkLocationPermission } from '../utils/PermissionUtils';

interface UseUserLocation {
    location: Coordinates | null;
    error: string | null;
    refreshLocation: () => Promise<void>;
}

const useUserLocation = (): UseUserLocation => {
    const [location, setLocation] = useState<Coordinates | null>(null);
    const [error, setError] = useState<string | null>(null);

    const fetchLocation = async () => {
        const hasPermission = await checkLocationPermission();
        if (!hasPermission) {
            setError('Location permission denied');
            return;
        }

        try {
            const coords = await LocationService.getCurrentLocation();
            setLocation(coords);
        } catch (err: any) {
            setError(err.message || 'Error fetching location');
        }
    };

    useEffect(() => {
        fetchLocation();
    }, []);

    return { location, error, refreshLocation: fetchLocation };
};

export default useUserLocation;
