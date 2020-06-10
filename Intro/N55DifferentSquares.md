### No.55 Different Squares
Given a rectangular matrix containing only digits, calculate the number of different 2 × 2 squares in it.

Example

For

matrix = [[1, 2, 1],
          [2, 2, 2],
          [2, 2, 2],
          [1, 2, 3],
          [2, 2, 1]]

the output should be
differentSquares(matrix) = 6.

Here are all 6 different 2 × 2 squares:

    1 2
    2 2
    2 1
    2 2
    2 2
    2 2
    2 2
    1 2
    2 2
    2 3
    2 3
    2 1

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.array.integer matrix

    Guaranteed constraints:
    1 ≤ matrix.length ≤ 100,
    1 ≤ matrix[i].length ≤ 100,
    0 ≤ matrix[i][j] ≤ 9.

    [output] integer
        The number of different 2 × 2 squares in matrix.
#### python
```python
def differentSquares(matrix):
    ListM=[]
    for r in range(len(matrix) - 1):
        for c in range(len(matrix[0])-1):
            temp=(matrix[r][c], matrix[r][c+1], matrix[r+1][c], matrix[r+1][c+1])
            ListM.append(temp)
    
    return len(set(ListM))
```