### No.6 MakeArrayConecutive2
Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.

Example

For statues = [6, 2, 3, 8], the output should be
makeArrayConsecutive2(statues) = 3.

Ratiorg needs statues of sizes 4, 5 and 7.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.integer statues

    An array of distinct non-negative integers.

    Guaranteed constraints:
    1 ≤ statues.length ≤ 10,
    0 ≤ statues[i] ≤ 20.

    [output] integer
        The minimal number of statues that need to be added to existing statues such that it contains every integer size from an interval [L, R] (for some L, R) and no other sizes.
#### python
```python
def makeArrayConsecutive2(statues):
    Maxium = 0
    Minmum = 20
    for i in range(len(statues)):
        if statues[i] > Maxium:
            Maxium = statues[i]
        if statues[i] < Minmum:
            Minmum = statues[i]
    return Maxium - Minmum + 1 - len(statues)
```
```python
def makeArrayConsecutive2(statues):
    inputrange = max(statues) - min(statues) - 1
    return inputrange - (len(set(statues)) - 2)
```