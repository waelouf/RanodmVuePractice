import { expect } from 'chai';
import { mount } from '@vue/test-utils';
import WeatherApp from '@/components/WeatherApp.vue';

describe('WeatherApp', () => {
  it('renders the WeatherApp component', () => {
    const wrapper = mount(WeatherApp);
    expect(wrapper.exists()).to.be.true;
  });

  it('displays the correct title', () => {
    const wrapper = mount(WeatherApp);
    const title = wrapper.find('h1');
    expect(title.text()).to.equal('Weather App');
  });

  it('displays the current temperature', () => {
    const wrapper = mount(WeatherApp);
    const temperature = wrapper.find('.temperature');
    expect(temperature.exists()).to.be.true;
  });

  it('displays the current weather condition', () => {
    const wrapper = mount(WeatherApp);
    const condition = wrapper.find('.condition');
    expect(condition.exists()).to.be.true;
  });

  it('displays the current location', () => {
    const wrapper = mount(WeatherApp);
    const location = wrapper.find('.location');
    expect(location.exists()).to.be.true;
  });

  it('displays the current date', () => {
    const wrapper = mount(WeatherApp);
    const date = wrapper.find('.date');
    expect(date.exists()).to.be.true;
  });

  it('displays the correct temperature unit', () => {
    const wrapper = mount(WeatherApp);
    const temperatureUnit = wrapper.find('.temperature-unit');
    expect(temperatureUnit.exists()).to.be.true;
  });

  // Add more test cases as needed

});
