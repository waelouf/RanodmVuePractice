pipeline {
  agent any
  stages {
    stage('checkout') {
      steps {
        git(url: 'https://github.com/waelouf/RanodmVuePractice', branch: 'main')
      }
    }

    stage('build') {
      parallel {
        stage('build dotnet') {
          steps {
            sh '''cd WeatherApp/Backend/WeatherApp
dotnet restore
dotnet dotnet build --no-restore WeatherApp.sln'''
          }
        }

        stage('build vue') {
          steps {
            sh '''cd WeatherApp/vue-weather-app
npm ci
npm run build --if-present'''
          }
        }

      }
    }

    stage('tests') {
      parallel {
        stage('tests dotnet') {
          steps {
            sh '''cd WeatherApp/Backend/WeatherApp
dotnet test --no-build --verbosity normal'''
          }
        }

        stage('tests vue') {
          steps {
            sh '''cd /WeatherApp/vue-weather-app
npm test'''
          }
        }

      }
    }

  }
}