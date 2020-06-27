### No.04 adjacentElementsProduct
Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

Example

For inputArray = [3, 6, -2, -5, 7, 3], the output should be
adjacentElementsProduct(inputArray) = 21.

7 and 3 produce the largest product.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.integer inputArray

    An array of integers containing at least two elements.

    Guaranteed constraints:
    2 ≤ inputArray.length ≤ 10,
    -1000 ≤ inputArray[i] ≤ 1000.

    [output] integer
        The largest product of adjacent elements.    

#### python
```python
def adjacentElementsProduct(inputArray):
    Maxium = -1000
    for i in range(len(inputArray) - 1):
        if inputArray[i] * inputArray[i + 1] > Maxium:
            Maxium = inputArray[i] * inputArray[i + 1]
    return Maxium
```
```python
def adjacentElementsProduct(inputArray):
    Maxium = float('-inf')
    for (a, b) in zip(inputArray, inputArray[1:]):
        Maxium = max(Maxium, a * b)
    return Maxium
```
```python
def adjacentElementsProduct(inputArray):
    return max([inputArray[i] * inputArray[i + 1] for i in range(len(inputArray) - 1)])
```
#### CSharp
```csharp
int adjacentElementsProduct(int[] inputArray)
{
    int m = int.MinValue;
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
     m = Math.Max(m, inputArray[i] * inputArray[i + 1]);
    }
    return m;
}
```
```csharp
int adjacentElementsProduct(int[] inputArray) {
    return inputArray.Select((i, j) => j > 0 ? i * inputArray[j-1] : int.MinValue).Max();
}
```