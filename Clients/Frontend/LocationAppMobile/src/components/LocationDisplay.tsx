import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { Coordinates } from '../services/LocationService';

interface LocationDisplayProps {
    location: Coordinates | null;
    error: string | null;
}

const LocationDisplay: React.FC<LocationDisplayProps> = ({ location, error }) => {
    if (error) {
        return <Text style={styles.errorText}>Error: {error}</Text>;
    }

    if (!location) {
        return <Text>Fetching location...</Text>;
    }

    return (
        <View>
            <Text>Latitude: {location.latitude}</Text>
            <Text>Longitude: {location.longitude}</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    errorText: {
        color: 'red',
    },
});

export default LocationDisplay;
