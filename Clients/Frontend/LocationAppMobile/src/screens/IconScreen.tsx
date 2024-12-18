
import React from 'react';
import { View, StyleSheet } from 'react-native';
import Icon from 'react-native-vector-icons/FontAwesome';

const IconScreen: React.FC = () => {
    return (
        <View style={styles.container}>
            <Icon name="star" size={50} color="#FFD700" />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
    },
});

export default IconScreen;
