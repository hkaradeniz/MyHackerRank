Permuting Two Arrays

https://www.hackerrank.com/challenges/two-arrays

Permuting Two Arrays

Consider two n-element arrays of integers, A=[a(0), a(1),...,a(n-1)] and B=[b(0),b(1),...,b(n-1)]. You want to permute 
them into some A' and B' such that the 
relation a'(i)+b'(i)>=k holds for all i where 0<=i<n. For example, if A=[0,1], B=[0,2], and k=1, a valid A',B' satisfying 
our relation would be A'=[1,0] and B'=[0,2].

You are given q queries consisting of A, B, and k. For each query, print YES on a new line if some permutations A',B' exist 
satisfying the relation above. If no valid permutations exist, print NO instead.

Input Format

The first line contains an integer, q, denoting the number of queries. The 3q subsequent lines describe each of the q
queries in the following format:

The first line contains two space-separated integers describing the respective values of a (the size of arrays A and B) 
and k (the relation variable).
The second line contains n space-separated integers describing the respective elements of array A.
The third line contains n space-separated integers describing the respective elements of array B.


Constraints
1<=q<=10
1<=n<=1000
1<=k<=10^9
0<=a(i),b(i)<=10^9

Output Format

For each query, print YES on a new line if valid permutations exist; otherwise, print NO.

Sample Input

2
3 10
2 1 3
7 8 9
4 5
1 2 2 1
3 3 3 4

Sample Output

YES
NO

Explanation

We perform the following two queries:

1- A=[2,3,1], B=[7,8,9], and .k=10 We permute these into A'=[1,2,3] and B'=[7,8,9] so that the following statements are true:
* a(0)+b(0) = 1+9 = 10 >=k
* a(1)+b(1) = 2+8 = 10 >=k
* a(2)+b(2) = 3+7 = 10 >=k

Thus, we print YES on a new line.

2- A=[1,2,2,1], B=[3,3,3,4], and k=5. To permute A and B into a valid A' and B', we would need at least three numbers in A to be 
greater than 1; as this is not the case, we print NO on a new line.
