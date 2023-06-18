import axios from 'axios';

export default {
  fetchWeatherData(city) {
    const apiUrl = `http://localhost?city=${city}`;

    return axios.get(apiUrl)
      .then(response => response.data)
      .catch(error => {
        console.error('Error fetching weather data:', error);
        throw error;
      });
  },
};
