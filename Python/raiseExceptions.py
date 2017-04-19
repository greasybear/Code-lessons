def boxPrint(symbol, width, height):
    if len(symbol) != 1:
        raise Exception('Symbol needs to be a string length of 1')
    if (width<2) or (height<2):
        raise Exception('width and height must be great or equal to 2')
    if (width <2) or (height<2):
        raise Exception('width and height must be great or equal to 2')
    print(symbol* width)
    for i in range(height-2):
        print(symbol + (' ' * (width-2))+symbol)
    print(symbol*width)

boxPrint('*', 15, 5)
boxPrint('O', 5, 15)
