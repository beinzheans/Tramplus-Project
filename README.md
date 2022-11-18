# Tramplus-Project
Project for Tramplus X HK MIT Innovation Node

# Description
Make an AI that combines traffic density, user preference and weather to make an travel iternary using trams. It will be made with Unity Engine and MLAgent Package. 

### Congestion Index

Traffic Density will be measured using seat availability. The counter will be equal to the seating capacity. The counter will decrease when the traffic has hit an enterance. It will increase when the traffic has hit an exit. The counter will be converted to percentage and its name is Congested Percent. Congested Percent is calculated by (total seats - counter) / total seats. The higher the Congested Percent, the more it is congested and vice versa.

Once we have the Congested Percent, we will take the average highest seat capacity. It is calculated by the sum the peak Congested Percent of every tram divided by number of trams. The average will change once per hour. This will be called the Congestion Index, which is the input for the AI.

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

As you can see, annually, there are only 1.6% of people using trams, even before the pandemic (2016). So, this will be our reference metric. To reiterate, each pedestrain will have a 1.6% chance of entering the trams. So if the traffic flow is 1000 people per hour then it is expected that 16 people will be on the tram.

