name = 'Zophie'
name[0]
#accesses element in list
'Zo' in name
#boolean algebra state
'xxx' in name
#should state false as this is not an element of the string
for letter in name:
    print(letter)

#this will print each indivdual char in the string
name = ' Zophie the cat'
newName = name[0:7] + 'the' + name[8:12]
print(newName)
#this creates a new string from slices of the old string
#this is done as string are immutable and cannot be changed like lists
