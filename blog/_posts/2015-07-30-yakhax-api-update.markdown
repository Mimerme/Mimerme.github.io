---
title:  "YakHax API Moving Forward"
date:   2015-07-30 10:57:00
description: Getting over the hurdles associated with opening the Yik-Yak API to the public
---

A lot of problems and bugs have arose during my attempt to expose the Yik-Yak API.
I've had a lot of resources at my disposal especially Soren21, the creator of the
unofficial Yik-Yak app for Windows Phones, who's GitHub project is very well designed
for easy reading as well as the /r/YikYak community with their extremely well documentation.
Because of this I will be cautious and release only the important information discovered from
the Yik-Yak API to prevent major abuse. This post will most likely be split into
two parts because I can't type this all in a single sitting.

## Preventing API abuse
One important idea when developing the API is how to prevent abuse. Obviously a company like
Snapchat has closed its once open-ish API because of abuse, and while history tends to repeat
itself we could at least make to prevent it. YikYak API requests are made to their endpoint.
They use two crucial query strings that allow the server to validate the request.
HASH and SALT. The salt as stated previously is the system time in seconds. Using this
the application builds a message (in the format of /api/getYaks?lat=99&long=99 etc.) and then hashes it using a specific key. Without this key you will not be able to make proper requests to the server and the server will return error 500. With this key, if the message is properly hashed you should get a series of numbers and letters with some punctuation in between. Well to prevent spammers I created a NodeJS server which takes in the message as a query parameter and outputs the HASH value, thus all the hashing takes place on the server. This allows me to throttle connections to prevent people who abuse the API.

## Network Interface
When designing the API (which took a grand total of 10 minutes) I made the decision to create YakHax as a network interface rather than a full on API that parses the output, which is most times in JSON format. This cut back on a lot of the code I would have to write and simplified my task, while allowing users to customize how they wanted to use the API.

## Debugging the Application
YikYak sends its requests through HTTPS which is known to protect against Man in the Middle attacks, which made a lot of tools for intercepting the requests useless. Thus I used a tool known as Charles. Routing the requests on my Android device through my PC through a proxy and also installing a security certificate made my job much easier. However because I had the free version I as alloted a maximum of 30 minutes of use at a time with the application of which I would have to restart the application. But the UI design and naviation of the program was flawless. Truely was one of the best applicationsI have ever used, and I am thinking about supporting the developer

## Android vs iOS
On the surface one could tell the UI differences from the YikYak Android app vs iOS app. But underlying there are also a few differences in the request. The API key I was talking about earlier is different between the iOS and Android applications. The Android key looks similar to an MD5 hash, while the iOS key contains hashes. I chose to debug and decompile the Android application because I did not have a jailbroken device on me and had much more familiarity with Android app development. As far as I know the Android app generates the key from its package signature and encodes that value as well to generate the key. The User-Agents when sending requests differ with Android labeling itself as 'Android' and iOS labeling itself as 'WebKit' (I may be wrong on this fact)

There are many more interesting findings I still have yet to announce and hopefully I will get more time to do so laster on. Stay fresh!
