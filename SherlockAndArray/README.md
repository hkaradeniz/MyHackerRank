Sherlock and Array

https://www.hackerrank.com/challenges/sherlock-and-array

Watson gives Sherlock an array A of length n. Then he asks him to determine if there exists 
an element in the array such that the sum of the elements on its left is equal to the sum 
of the elements on its right. If there are no elements to the left/right, then the sum is considered to be zero. 
Formally, find an i, such that, A(0)+A(1)+A(2)+...+A(i-1)=A(i+1)+A(i+2)+...+A(n-1).


Input Format

The first line contains T, the number of test cases. For each test case, the first line contains n, 
the number of elements in the array A. The second line for each test case contains n space-separated integers, denoting the array A.


Constraints
1<=T<=10
1<=n<=10^5
1<=A(i)<=2x10^4
1<=i<=N
 


Output Format

For each test case print YES if there exists an element in the array, such that the sum of the 
elements on its left is equal to the sum of the elements on its right; otherwise print NO.

Sample Input 0

2
3
1 2 3
4
1 2 3 3

Sample Output 0

NO
YES

Explanation 0

For the first test case, no such index exists. 
For the second test case, A[0]+A[1]=A[3], therefore index 2 satisfies the given conditions.
