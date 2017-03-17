Jumping on the Clouds Revisited

https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited

Aerith is playing a cloud game! In this game, there are n clouds numbered sequentially from 0 to n-1. 
Each cloud is either an ordinary cloud or a thundercloud.

Aerith starts out on cloud  with energy level E=100. She can use  unit of energy to make a jump of size k to 
cloud (i+k)%n, and she jumps until she gets back to cloud 0. If Aerith lands on a thundercloud, her energy (E) 
decreases by 2 additional units. The game ends when Aerith lands back on cloud .

Given the values of n, k, and the configuration of the clouds, can you determine the final value of  after the game ends?

Note: Recall that % refers to the modulo operation.

Input Format

The first line contains two space-separated integers, n (the number of clouds) and k (the jump distance), respectively. 
The second line contains n space-separated integers describing the respective values of clouds c(0),c(1),...,c(n-1). 
Each cloud is described as follows:

If c(i)=0, then cloud i is an ordinary cloud.
If c(i)=1, then cloud i is a thundercloud.


Constraints
2<=n<=25
1<=k<=n
n%k=0;
c(i) E {0,1}

Output Format

Print the final value of E on a new line.

Sample Input

8 2
0 0 1 0 0 1 1 0

Sample Output

92

Explanation

In the diagram below, red clouds are thunderclouds and purple clouds are ordinary clouds:

https://s3.amazonaws.com/hr-challenge-images/0/1462454878-26f414ec0f-may4.png


Observe that our thunderclouds are the clouds numbered 2, 5, and 6. Aerith makes the following sequence of moves:

1- Move: 0 -> 2, Energy: E=100-1-2=97.
2- Move: 2 -> 4, Energy: E=97-1=96.
3- Move: 4 -> 6, Energy: E=96-1-2=93.
4- Move: 6 -> 0, Energy: E=93-1=92.

Thus, we print 92 as our answer.
