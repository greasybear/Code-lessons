import traceback
try: raise Exception('This is an error')
except:
    errorFile= open('error_log.txt', 'a')
    errorFile.write(traceback.format_exc())
    errorFile.close()                       #creates new txt file to log errors
    print('the traceback info was written to file')
    #this allows the program to continue running while loggging the issue and path
