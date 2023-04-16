def remove_smallest(numbers):
    if(numbers):
        n=numbers[:]
        dl=len(numbers)
        t=numbers[0]
        for i in range(dl):
            if( numbers[i]<t):
                t=numbers[i] 
        n.remove(t)
        return n
    return numbers
