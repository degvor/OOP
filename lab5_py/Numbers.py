from abc import abstractmethod, ABC

class Number(ABC):
    def __init__(self):
        self._value = 0

    @abstractmethod
    def num_up(self):
        pass

    @abstractmethod
    def num_down(self):
        pass

    @abstractmethod
    def to_int(self):
        pass

    @abstractmethod
    def _from_int(self, num):
        pass

class NumberBinary(Number):
    def __init__(self, num):
        super().__init__()
        self._value = self._from_int(num)

    def num_up(self):
        self._value = self._from_int(self.to_int() + 1)

    def num_down(self):
        self._value = self._from_int(self.to_int() - 1)

    def to_int(self):
        temp = str(self._value)
        res = 0
        for i in range(len(temp)):
            res += int(temp[-(i+1)]) * (2 ** i)

        return int(res)

    def _from_int(self, num):
        return int(bin(num)[2:])

    def __str__(self):
        return str(self._value)


class NumberOctal(Number):
    def __init__(self, num):
        super().__init__()
        self._value = self._from_int(num)

    def num_up(self):
        self._value = self._from_int(self.to_int() + 1)

    def num_down(self):
        self._value = self._from_int(self.to_int() - 1)

    def to_int(self):
        temp = str(self._value)
        res = 0
        for i in range(len(temp)):
            res += int(temp[-(i+1)]) * (8 ** i)

        return int(res)

    def _from_int(self, num):
        return int(oct(num)[2:])

    def __str__(self):
        return str(self._value)