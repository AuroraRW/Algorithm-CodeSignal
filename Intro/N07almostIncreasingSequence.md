### No.7 almostIncreasingSequence
Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.
Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0 < a1 < ... < an. Sequence containing only one element is also considered to be strictly increasing.
Example
For sequence = [1, 3, 2, 1], the output should be
almostIncreasingSequence(sequence) = false.

There is no one element in this array that can be removed in order to get a strictly increasing sequence.

For sequence = [1, 3, 2], the output should be
almostIncreasingSequence(sequence) = true.

You can remove 3 from the array to get the strictly increasing sequence [1, 2]. Alternately, you can remove 2 to get the strictly increasing sequence [1, 3].
Input/Output
[execution time limit] 4 seconds (py3)

[input] array.integer sequence

Guaranteed constraints:
2 ≤ sequence.length ≤ 105,
-105 ≤ sequence[i] ≤ 105.

[output] boolean
    Return true if it is possible to remove one element from the array in order to get a strictly increasing sequence, otherwise return false.
#### python
```python
def first_bad_pair(sequence):
    """Return the first index of a pair of elements where the earlier
    element is not less than the later elements. If no such pair
    exists, return -1."""
    for i in range(len(sequence) - 1):
        if sequence[i] >= sequence[i + 1]:
            return i
    return -1

def almostIncreasingSequence(sequence):
    """Return whether it is possible to obtain a strictly increasing
    sequence by removing no more than one element from the array."""
    j = first_bad_pair(sequence)
    if j == -1:
        return True  # List is increasing
    if first_bad_pair(sequence[j - 1:j] + sequence[j + 1:]) == -1:
        return True  # Deleting earlier element makes increasing
    if first_bad_pair(sequence[j:j + 1] + sequence[j + 2:]) == -1:
        return True  # Deleting later element makes increasing
    return False  # Deleting either does not make increasing
```