SELECT countries.name, languages.language, languages.percentage
FROM countries
JOIN languages ON languages.country_id  = countries.id 
WHERE languages.language = 'Slovene'
GROUP BY countries.id;

SELECT countries.name AS countries, COUNT(cities.country_id) AS cities
FROM countries
JOIN cities ON countries.id = cities.country_id
GROUP BY countries.id
ORDER BY  COUNT(cities.country_id) DESC;

SELECT cities.name AS cities, cities.population
FROM cities 
JOIN countries ON countries.id  = cities.country_id 
Where countries.name = 'Mexico'
ORDER BY cities.population DESC;

SELECT countries.name,languages.percentage,languages.language
FROM languages
JOIN countries ON languages.country_id = countries.id
WHERE languages.percentage > 89
ORDER BY languages.percentage DESC;

SELECT countries.name, countries.surface_area,countries.population
FROM countries
WHERE surface_area < 501 AND population > 100000;

SELECT countries.name, countries.government_form, countries.capital,countries.life_expectancy
FROM countries
WHERE government_form = 'Constitutional Monarchy' AND capital >200 AND life_expectancy > 75;

SELECT countries.name, cities.name,cities.district,cities.population
FROM countries
JOIN cities ON countries.id = cities.country_id
WHERE countries.name = 'Argentina' AND cities.district = 'Buenos Aires' AND cities.population > 500000;

SELECT countries.region, COUNT(countries.id) AS countries
FROM countries
GROUP BY countries.region
ORDER BY countries DESC;












