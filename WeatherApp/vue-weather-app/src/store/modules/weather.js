import WeatherService from '../../Services/WeatherService';

const actions = {
  async fetchWeatherData({ commit }, city) {
    try {
      const data = await WeatherService.fetchWeatherData(city);
      console.log(data)
      commit('setWeatherData', data);
    } catch (error) {
      console.error('Error fetching weather data:', error);
    }
  },
};
