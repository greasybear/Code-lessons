#data structure that represents Tic Tac Toe
theBoard = {'top-l': '', 'top-m': '', 'top-r':'', 'mid-l': '', 'mid-m': '', 'mid-r':'','bot-l': '', 'bot-m': '', 'bot-r':''}
import pprint as pp
pp.pprint(theBoard)
def printBoard(board):
	print(board['top-l'] + '|' + board['top-m']+ '|' + board['top-r'])
	print('-----')
	print(board['mid-l'] + '|' + board['mid-m']+ '|' + board['mid-r'])
	print('-----')
	print(board['bot-l'] + '|' + board['bot-m']+ '|' + board['bot-r'])
#the above dictionary will hold the value on the board and currently is blank
#the function will use the values to print a representation of a board 
