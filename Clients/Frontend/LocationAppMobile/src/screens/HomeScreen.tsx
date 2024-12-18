// src/screens/HomeScreen.tsx
import React, { useState, useEffect } from 'react';
import { View, TextInput, Button, StyleSheet, Text } from 'react-native';
import Geolocation from '@react-native-community/geolocation';
import axios from 'axios';

const HomeScreen: React.FC = () => {
    const [fullName, setFullName] = useState('');
    const [location, setLocation] = useState<{ latitude: number; longitude: number } | null>(null);
    const [error, setError] = useState('');

    // Automatically fetch the location when the component is mounted
    useEffect(() => {
        Geolocation.getCurrentPosition(
            (position) => {
                const { latitude, longitude } = position.coords;
                setLocation({
                    latitude,
                    longitude,
                });
            },
            (err) => setError(err.message),
            { enableHighAccuracy: true, timeout: 15000, maximumAge: 10000 }
        );
    }, []);

    const submitForm = async () => {
        if (!fullName || !location) {
            alert('Please provide both full name and location');
            return;
        }

        try {
            await axios.post('https://localhost:7137/createRecord', {
                name: fullName,
                latitude: location.latitude,
                longitude: location.longitude,
            });
            alert('Data submitted successfully');
        } catch (err) {
            alert('Error submitting data');
        }
    };

    return (
        <View style={styles.container}>
            <TextInput
                style={styles.input}
                placeholder="Full Name"
                value={fullName}
                onChangeText={setFullName}
            />
            {location ? (
                <Text>Location: {location.latitude}, {location.longitude}</Text>
            ) : (
                <Text>Fetching location...</Text>
            )}
            {error && <Text style={styles.error}>{error}</Text>}
            <Button title="Submit" onPress={submitForm} />
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
    input: {
        height: 40,
        borderColor: 'gray',
        borderWidth: 1,
        marginBottom: 10,
        width: '80%',
        paddingLeft: 8,
    },
    error: {
        color: 'red',
    },
});

export default HomeScreen;
