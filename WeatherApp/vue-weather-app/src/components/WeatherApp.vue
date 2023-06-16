<template>
<template>
  <div>
    <h2>Weather Information</h2>
    <div v-if="weatherData">
      <h3>{{ weatherData.location.name }}, {{ weatherData.location.country }}</h3>
      <p>Temperature: {{ weatherData.currentWeather.temp_c }}°C</p>
      <p>Humidity: {{ weatherData.currentWeather.humidity }}%</p>
      <p>Wind Speed: {{ weatherData.currentWeather.wind_kph }} km/h</p>
      <p>Wind Direction: {{ weatherData.currentWeather.wind_dir }}</p>
      <p>Condition: {{ weatherData.currentWeather.condition.text }}</p>
      <img :src="'https:' + weatherData.currentWeather.condition.icon" alt="Condition Icon" />
      <p>Local Time: {{ weatherData.location.localtime }}</p>
    </div>
    <div v-else>
      <p>No weather data available.</p>
    </div>
  </div>
</template>
</template>
<script lang="js">
import WeatherService from '../Services/WeatherService';

export default {
  data() {
    return {
      weatherData: null,
    };
  },
  methods: {
    async fetchWeatherData(city) {
      try {
        this.weatherData = await WeatherService.fetchWeatherData(city);
        console.log('Weather data:', this.weatherData.currentWeather); 
      } catch (error) {
        console.error('Error fetching weather data:', error);
      }
    },
  },
  mounted() {
    console.log('mounted')
    this.fetchWeatherData('London'); // Example: Fetch weather data for 'London'
  },
};
</script>