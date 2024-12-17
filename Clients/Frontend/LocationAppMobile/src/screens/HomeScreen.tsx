import React from 'react';
import { View, Button, StyleSheet } from 'react-native';
import useUserLocation from '../hooks/useUserLocation';
import LocationDisplay from '../components/LocationDisplay';

const HomeScreen: React.FC = () => {
    const { location, error, refreshLocation } = useUserLocation();

    return (
        <View style={styles.container}>
            <LocationDisplay location={location} error={error} />
            <Button title="Refresh Location" onPress={refreshLocation} />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        padding: 16,
    },
});

export default HomeScreen;
