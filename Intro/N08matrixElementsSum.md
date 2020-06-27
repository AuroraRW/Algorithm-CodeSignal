### No.8 Matrix Elements Sum
After becoming famous, the CodeBots decided to move into a new building together. Each of the rooms has a different cost, and some of them are free, but there's a rumour that all the free rooms are haunted! Since the CodeBots are quite superstitious, they refuse to stay in any of the free rooms, or any of the rooms below any of the free rooms.

Given matrix, a rectangular matrix of integers, where each value represents the cost of the room, your task is to return the total sum of all rooms that are suitable for the CodeBots (ie: add up all the values that don't appear below a 0).

Example

    For

    matrix = [[0, 1, 1, 2], 
              [0, 5, 0, 0], 
              [2, 0, 3, 3]]

    the output should be
    matrixElementsSum(matrix) = 9.  

![title](P08-1.png)  

There are several haunted rooms, so we'll disregard them as well as any rooms beneath them. Thus, the answer is 1 + 5 + 1 + 2 = 9.

For

matrix = [[1, 1, 1, 0], 
          [0, 5, 0, 1], 
          [2, 1, 3, 10]]

the output should be
matrixElementsSum(matrix) = 9.  

![title](P08-2.png)  

Note that the free room in the final column makes the full column unsuitable for bots (not just the room directly beneath it). Thus, the answer is 1 + 1 + 1 + 5 + 1 = 9.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.array.integer matrix

    A 2-dimensional array of integers representing the cost of each room in the building. A value of 0 indicates that the room is haunted.

    Guaranteed constraints:
    1 ≤ matrix.length ≤ 5,
    1 ≤ matrix[i].length ≤ 5,
    0 ≤ matrix[i][j] ≤ 10.

    [output] integer
        The total price of all the rooms that are suitable for the CodeBots to live in.
#### python
```python
def matrixElementsSum(matrix):
    # i is column, j is row
    sum = 0
    for i in range(len(matrix[0])):
        for j in range(len(matrix)):
            if matrix[j][i] == 0:
                break
            sum = sum + matrix[j][i]
    return sum
```
```python
from itertools import takewhile
def matrixElementsSum(matrix):
    mt = list(zip(*matrix)) # mt is [(0, 0, 2), (1, 5, 0), (1, 0, 3), (2, 0, 3)]
    return sum([sum(takewhile(lambda x: x>0, y)) for y in mt])
```
```csharp
int matrixElementsSum(int[][] matrix) {
// i is column, j is row
    int sum = 0;
    for (int i = 0; i < matrix[0].Length; i++)
    {
        for (int j = 0; j < matrix.Length; j++)
        {
            if (matrix[j][i] == 0) break;
            sum = sum + matrix[j][i];
        }
    }
    return sum;
}
```
```csharp
int matrixElementsSum(int[][] matrix) {
    int sum = 0;
    for (int c=0; c<matrix[0].Length; c++) {
        sum += matrix.TakeWhile(_ => _[c] != 0).Sum(_ => _[c]);
    }
    return sum;
}
```