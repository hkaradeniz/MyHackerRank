String Construction

https://www.hackerrank.com/challenges/string-construction

String Construction

Amanda has a string, s, of m lowercase letters that she wants to copy into a new string, p. 
She can perform the following operations any number of times to construct string p:

Append a character to the end of string p at a cost of 1 dollar.
Choose any substring of p and append it to the end of p at no charge.
Given  strings (i.e., s(0),s(1),....,s(n-1)), find and print the minimum cost of copying each s(i) to p(i) on a new line.

Input Format

The first line contains a single integer, n, denoting the number of strings. 
Each line i of the n subsequent lines contains a single string, s(i).

Constraints
1<=n<=5
1<=m<=10^5

Subtasks
1<=m<=10^3 for 45% of the maximum score.


Output Format

For each string s(i) (where 0<=i<n), print the minimum cost of constructing string p(i) on a new line.

Sample Input

2
abcd
abab

Sample Output

4
2


Explanation
Query 0: We start with s="abcd" and p"".

Append character 'a' to p at a cost of 1 dollar, p="a".
Append character 'b' to p at a cost of 1 dollar, p="ab".
Append character 'c' to p at a cost of 1 dollar, p="abc".
Append character 'd' to p at a cost of 1 dollar, p="abcd".
Because the total cost of all operations is 1+1+1+1=4 dollars, we print 4 on a new line.

Query 1: We start with s="abab" and p="".

Append character 'a' to p at a cost of 1 dollar, p="a".
Append character 'b' to p at a cost of 1 dollar, p="ab".
Append substring "ab" to p at no cost, p="abab".
Because the total cost of all operations is 1+1=2 dollars, we print 2 on a new line.

Note

A substring of a string S is another string S' that occurs "in" S (Wikipedia). For example, the 
substrings of the string "abc" are "a", "b" ,"c", "ab", "bc", and "abc".
