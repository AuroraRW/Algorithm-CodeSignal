### No.53 Valid Time
Check if the given string is a correct time representation of the 24-hour clock.

Example

    For time = "13:58", the output should be
    validTime(time) = true;
    For time = "25:51", the output should be
    validTime(time) = false;
    For time = "02:76", the output should be
    validTime(time) = false.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string time

    A string representing time in HH:MM format. It is guaranteed that the first two characters, as well as the last two characters, are digits.

    [output] boolean
        true if the given representation is correct, false otherwise.
#### python
```python
def validTime(time):
    ListTime=time.split(':')
    hour=int(ListTime[0])
    minute=int(ListTime[1])
    if hour<0 or hour>=24:
        return False
    if minute<0 or minute>=60:
        return False
    return True
```
```python
def validTime(time):
    h,m=map(int,time.split(":"))
    return 0<=h<24 and 0<=m<60
```