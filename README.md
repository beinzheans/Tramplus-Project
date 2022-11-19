# Tramplus-Project
Project for Tramplus X HK MIT Innovation Node

# Description
Make an AI that combines traffic density, user preference and weather to make an travel iternary using trams. It will be made with Unity Engine and MLAgent Package. 

### Congestion Index

Traffic Density will be measured using seat availability. The counter will be equal to the seating capacity. The counter will decrease when the traffic has hit an enterance. It will increase when the traffic has hit an exit. The counter will be converted to percentage and its name is Congested Percent. Congested Percent is calculated by counter / total seats. The higher the Congested Percent, the more it is congested and vice versa.

Once we have the Congested Percent, we will take the average highest seat capacity. It is calculated by the sum the peak Congested Percent of every tram divided by number of trams. In this simulation, the average will chance once per minute. This will be called the Congestion Index, which is the input for the AI.

The AI should be able to determine what is the optimum Congestion Index people will accept.

### Pedestrian Behaviour

Pedestrain Behaviour will refer to how pedestrains on the sidewalk will react. This will be as accurate as the real world as possible. We will use People Density to determine the number of people and each pedestrain will have a random chance to enter the tram.

#### People Density

People Density refers to how many people will be spawned or moving. The people will spawn based on People Density (people / square metre). After research, the safety limit is 2 people / square metre for standing, and for moving or queueing is 4 people / square metre. We will base our traffic spawn on the following metrics.

0 - 0.5: Very low
0.5 - 1: Low
1 - 2: Moderate
2 - 2.5: High
3 - 4: Very High
4 - 5: Extreme

The simulation will have a slider that can directly change People Density ranging from 0 to 5 inclusive. The higher the slider, the more people there will be and vice versa.

#### Chance of Entering Trams

![image](https://user-images.githubusercontent.com/112590223/202681312-284b70da-2a83-4528-9b35-6b4b3c471762.png)

As you can see, annually, there are only 1.4% of people using trams, even before the pandemic (2016). So, this will be our reference metric. To reiterate, each pedestrain will have a 1.4% chance of entering the trams. So if the traffic flow is 1000 people per hour then it is expected that 14 people will be on the tram, which is quite low.

#### Queueing in line

In the real world, pedestrains will queue in lines when the tram is gone. In this simulation, there will be no queueing time. If the tram is not there, then no passengers will be on the tram.

#### Leaving the tram

All passangers will have a 10% to leave every time a tram makes their stop. If this random value is in a range of values, then the passenger will leave the tram.

### Tram Behaviour

#### Frequency

The trams will have a 1 - 2 minute interval in the real world. For the sake of simulation, the interval will be 30 seconds.

#### In the station

The trams will stay in their station for 15 seconds. After 15 seconds, the tram will leave.

### Weather

The simulation will allow a temperature ranging from 15 to 30 to be picked from. It will also allow what condition the weather will be. For example, sunny, overcast, rainy etc. These two will be the inputs for the AI. The AI should be able to determine what is the best condition for a certain condition. For example, in sunny weather, the AI should be able to give plans for air-conditioned places.

The data can be found on TripAdvisor. By using reviews, we can get data easily.

### User preference

This will be the fourth input for the AI. This is also the last stage, so it might not be implemented due to time constraints. The AI should be able to determine what is the most suitable for different kinds of people. For example, if one likes technology, then the AI should give in places that has more technology, such as the Space Museum, instead of something related with arts.
