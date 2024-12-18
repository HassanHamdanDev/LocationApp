
import React, { useState } from 'react';
import { View, Button, FlatList, Text, StyleSheet } from 'react-native';
import axios from 'axios';

const RecordsScreen: React.FC = () => {
    const [records, setRecords] = useState<any[]>([]);
    const [error, setError] = useState('');

    const fetchRecords = async () => {
        try {
            const response = await axios.get('https://localhost:7137/records');
            setRecords(response.data);
        } catch (err) {
            setError('Failed to fetch records');
        }
    };

    return (
        <View style={styles.container}>
            <Button title="Fetch Records" onPress={fetchRecords} />
            {error && <Text style={styles.error}>{error}</Text>}
            <FlatList
                data={records}
                renderItem={({ item }) => (
                    <View style={styles.record}>
                        <Text>{item.name}</Text>
                        <Text>{item.coordinate}</Text>
                    </View>
                )}
                keyExtractor={(item) => item.id.toString()}
            />
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
    record: {
        padding: 10,
        borderBottomWidth: 1,
        borderColor: '#ddd',
    },
    error: {
        color: 'red',
    },
});

export default RecordsScreen;
