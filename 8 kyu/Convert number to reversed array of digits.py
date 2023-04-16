def digitize(n):
    liczba=str(n)
    dl=len(liczba)
    list=[]
    for i in range(dl):
        list.insert(i, int(liczba[i]))
    list.reverse()
    return list
