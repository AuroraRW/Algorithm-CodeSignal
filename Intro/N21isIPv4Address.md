### No.21 isIPv4Address
An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. There are two versions of the Internet protocol, and thus two versions of addresses. One of them is the IPv4 address.

Given a string, find out if it satisfies the IPv4 address naming rules.

Example

    For inputString = "172.16.254.1", the output should be
    isIPv4Address(inputString) = true;

    For inputString = "172.316.254.1", the output should be
    isIPv4Address(inputString) = false.

    316 is not in range [0, 255].

    For inputString = ".254.255.0", the output should be
    isIPv4Address(inputString) = false.

    There is no first number.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string inputString

    A string consisting of digits, full stops and lowercase English letters.

    Guaranteed constraints:
    1 ≤ inputString.length ≤ 30.

    [output] boolean
        true if inputString satisfies the IPv4 address naming rules, false otherwise.
#### python
```python
def isIPv4Address(inputString):

    number = inputString.split('.')
    if len(number) == 4:
        for i in number:
            if i.isdigit():
                i = int(i)
                if i < 0 or i > 255:
                    return False
            else:
                return False
        return True
    else:
        return False

# return len(p) == 4 and all(n.isdigit() and 0 <= int(n) < 256 for n in p)
```