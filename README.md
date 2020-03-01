# WebFrameworkBenchmark
This repository contains project for several web framework with the same task. The purpose is to benchmark its performance with [wrk](https://github.com/wg/wrk) on your perspective (local, ur own sevrer, etc).

## What are we building
We will benchmarking with real-life scenario. There are 4 scenario that we will use:

- 1.Hello World

Simply respond with JSON containing __Hello World__ string array["Hello", "World"].

- 2.Computation

Coompute 100.000 Fibonacci Numbers

Start from this scenario, we will use __MySql__ for stroring data. 
We have 3 tables, the first one is contains students information. The second one is contains class listing. Then we have join Table as Enrollment as a result of many-to-many relationship between student-book. Student can enroll on many classes, and classes can be contains more than one students.

- 3.Simple Listing

Return Students Listing with fullname instead of firstname & lastname

- 4.Relation Listing

Return relational many-to-many mapping between students and class. We will listing  all students with fullname instead of firstname & lastname and order by their fullname. All the students has been enrolled on "Math" class and a list of every other class that student has been enrollment with order title class by ascending.

## Notes

- __JSON Format__

For __Case 3&4__ We will using standar format:

```json
  "isError": bool
  "statusCode": int
  "message": string
  "results": {object data}
```

- __Why MySQL__

We want to make sure that this benchmark will represent our real life scenario as possible. MySql is one of the popular database. So its good to starting with. For standar, this repo contains Database schemes to use, so we can skip thinking and wasting time to build our preferable database scheme.

- __Testing Environment__

For simple use case, we will benchmark with _vps server: 1 CPU, 512 MB - $5 / month_ on digitalocean. 

- __Using Docker__

Every web framework build this scenario on top docker ecosystem. The reason is to skip wasting time on server to setup. It's worst!

- __Data Layer Tools__

For building the last two endpoints we’ll use the tools each framework provides to achieve our goal in the easiest possible way.

- __CI/CD__

For good further sake, we will add _CI/CD_ configuration next.

# Contribution
Feel free to contribute. We want to everyone to take advantage or learn something from this benchmark. There are 2 type of contributing to this:

1. Add new WebAPIFramework

Since we dont have any limitation to use framework, we are open to accept any new web api framework approaches.

2. Edit source code of existing webAPIFramework

We love clean, performance-matter, and KIS principle. If you find any code that affect one of those criteria, we are open for PR. We will review alongside with the contributors of that code.

# License
MIT


