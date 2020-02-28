# WebFrameworkBenchmark
This repository contains project for several web framework with same task. The purpose is to benchmark its performance with [wg/wrk](https://github.com/wg/wrk) on your perspective (local, ur own sevrer, etc).

## What are we building
We will benchmarking with real-life case with some scenario. There 4 scenario that we will use:

[-] Hello World
Simply respond with JSON containing Hello __Hello World__ string.

[-] Computation
Coompute 100.000 Fibonacci Numbers

Start from this scenario, we will use __MySql__ for stroring data. 
We have 2 tables, the first one is contains owner information. The second one is contains books listing with ownerId as foreign key to pointing who has the book. Ok, lets go.

[-] Simple Listing
Return Owner Listing as JSON.

[-] Relation Listing
Return relational many-to-many mapping between owners and books. We will listing  all owners who has borrowed "Harry Potter" book and everybook that owner has been borrowed.

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
Feel free to contribute. We want to everyone take advantage or learn something from this benchmark. There are 2 type of contributing to this:

1. Add new WebAPIFramework

Since we dont have any limitation to what to use, we are open to accept any new web api framework approaches.

2. Edit source code of existing webAPIFramework

We love clean, performance-matter, and KIS principle. If you find any code that affect one of those criteria, we are open for PR. We will review alongside with the contributors of that code.

# License
MIT


