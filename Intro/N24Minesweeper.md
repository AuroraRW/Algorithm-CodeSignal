### No.24 Minesweeper
In the popular Minesweeper game you have a board with some mines and those cells that don't contain a mine have a number in it that indicates the total number of mines in the neighboring cells. Starting off with some arrangement of mines we want to create a Minesweeper game setup.

Example

For

matrix = [[true, false, false],
          [false, true, false],
          [false, false, false]]

the output should be

minesweeper(matrix) = [[1, 2, 1],
                       [2, 1, 1],
                       [1, 1, 1]]

Check out the image below for better understanding:  

![title](P24-1.png)  

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.array.boolean matrix

    A non-empty rectangular matrix consisting of boolean values - true if the corresponding cell contains a mine, false otherwise.

    Guaranteed constraints:
    2 ≤ matrix.length ≤ 100,
    2 ≤ matrix[0].length ≤ 100.

    [output] array.array.integer
        Rectangular matrix of the same size as matrix each cell of which contains an integer equal to the number of mines in the neighboring cells. Two cells are called neighboring if they share at least one corner.
#### python
```python
def minesweeper(matrix):
    import collections
    temp_m = []
    temp_m.append([False] * (len(matrix[0]) + 2))
    for i in matrix:
        temp_line = []
        temp_line.append(False)
        for j in i:
            temp_line.append(j)
        temp_line.append(False)
        temp_m.append(temp_line)
    temp_m.append([False] * (len(matrix[0]) + 2))

    result = []
    for i in range(1, len(temp_m) - 1):
        temp = []
        for j in range(1, len(temp_m[0]) - 1):
            number_1 = collections.Counter(temp_m[i - 1][j - 1:j + 2])
            number_2 = collections.Counter(temp_m[i][j - 1:j + 2])
            number_3 = collections.Counter(temp_m[i + 1][j - 1:j + 2])
            number_all = number_1[True] + number_2[True] + number_3[True]
            if temp_m[i][j] == True:
                temp.append(number_all - 1)
            else:
                temp.append(number_all)
        result.append(temp)
    return result
```