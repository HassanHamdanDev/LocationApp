import { Platform } from 'react-native';
import { check, request, PERMISSIONS, RESULTS, Permission } from 'react-native-permissions';

export const checkLocationPermission = async (): Promise<boolean> => {
    const permission: Permission =
        Platform.OS === 'android'
            ? PERMISSIONS.ANDROID.ACCESS_FINE_LOCATION
            : PERMISSIONS.IOS.LOCATION_WHEN_IN_USE;

    const result = await check(permission);
    if (result === RESULTS.GRANTED) { return true; }
    if (result === RESULTS.DENIED) {
        const requestResult = await request(permission);
        return requestResult === RESULTS.GRANTED;
    }
    return false;
};
