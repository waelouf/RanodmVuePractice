## Build web api command
```
docker `
build -t waelouf-playground/weather-app-api `
 -f .\WeatherAppWebApi\Dockerfile `
 . 
```

## Build vue app
```
docker build -t waelouf-playground/weather-app-vue .
```

## Some docker commands

Open a file in the container

```
cat file_name
```

Install curl

```
apk add curl
```