import Geolocation, { GeolocationResponse } from '@react-native-community/geolocation';

export interface Coordinates {
    latitude: number;
    longitude: number;
}

const LocationService = {
    getCurrentLocation: (): Promise<Coordinates> =>
        new Promise((resolve, reject) => {
            Geolocation.getCurrentPosition(
                (position: GeolocationResponse) => {
                    const { latitude, longitude } = position.coords;
                    resolve({ latitude, longitude });
                },
                error => reject(error),
                { enableHighAccuracy: true, timeout: 15000, maximumAge: 10000 }
            );
        }),
};

export default LocationService;
