<template>
  <div>
    <h2>Weather Information</h2>
    <input id="txtCity" v-model="city" @keyup="onKeyUp" />
    <div v-if="weatherData">
      <h3>{{ weatherData.location.name }}, {{ weatherData.location.country }}</h3>
      <p>Temperature: {{ weatherData.currentWeather.temperatureCelsius }}°C</p>
      <p>Temperature: {{ weatherData.currentWeather.temperatureFahrenheit }}°F</p>
      <p>Humidity: {{ weatherData.currentWeather.humidity }}%</p>
      <p>Wind Speed: {{ weatherData.currentWeather.windSpeedKph }} km/h</p>
      <p>Wind Speed: {{ weatherData.currentWeather.windSpeedMph }} m/h</p>
      <p>Wind Direction: {{ weatherData.currentWeather.windDirection }}</p>
      <p>Condition: {{ weatherData.currentWeather.condition.text }}</p>
      <img :src="'https:' + weatherData.currentWeather.condition.icon" alt="Condition Icon" />
      <p>Local Time: {{ weatherData.location.localTime }}</p>
    </div>
    <div v-else>
      <p>No weather data available.</p>
    </div>
  </div>
</template>
<script lang="js">
import WeatherService from '../Services/WeatherService'
import { debounce } from '../Utilities/Helper'

export default {
  data() {
    return {
      weatherData: null,
      debounceFn: null,
      city:'London'
    }
  },
  methods: {
    async fetchWeatherData() {
      try {
        this.weatherData = await WeatherService.fetchWeatherData(this.city)
      } catch (error) {
        console.error('Error fetching weather data:', error)
      }
    },
    onKeyUp() {
      this.debounceFn()
    }
  },
  mounted() {
    this.debounceFn = debounce(() => this.fetchWeatherData())
  },
}
</script>