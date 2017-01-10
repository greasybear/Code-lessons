import pprint as pp
message = 'it was a bright cold day in April, and the colocks were striking thirteen.'
count = {}
#above we assign the string to the variable message and create a dictionary
for character in message.upper():
    count.setdefault(character, 0)
    count[character] = count[character] +1
pp.pprint(count)

#above we have a for loop that uses the upper method to assign
#all letters to uppercase so that they aren't counted separately
##this loop goes through and assigns each letter a value based on how many
##times it appears in the string
