import random as rd
print ('Hello. What is your name?')
name = input()
if name.isdigit():
    print('that is a number idiot. But whatever, I will go with it')
print('Well, '+ name +', I was thinking of a number between 1 and 20.')
secretNumber = rd.randint (1, 20)
for guessesTaken in range(1, 7):
    print('Take a guess.')
    try:
        guess =int(input())
        if guess < secretNumber:
            print('Your guess is too low')
        elif guess > secretNumber:
            print('Your guess is too high')
        else:
            break # this condition is for the correct guess
    except ValueError:
        print('please type a number not a word')
if guess == secretNumber:
    print('Good job ' + name +', you guessed the number in '+ str(guessesTaken) + ' guesses.')
else:
    print('Nope. The number I was thinking of was ' + str(secretNumber))
