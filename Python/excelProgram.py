import pandas as pd

pd.set_option('max_columns',60)

file = 'c:/Users/Awillis/Desktop/Excel Trackers/PythonApp/testExcel.xls'

df = pd.read_excel(file)

df = df.drop(df.columns[37:52], axis=1)

df = df.drop(['Master Customer', 'Customer Type', 'Is IoT', 'List Price', 'Unit Price'], axis=1)

#this is where copying and pasting column I should go-should work???
quant=df['Quantity']

df = df.drop('Quantity', 1)

df.insert(21, 'Quantity', quant)

new_col = df['Customer'].str.cat(df['Customer Number'], sep='-')

df = df.drop(['Customer','Customer Number'], axis=1)

df.insert(5,'Customer',new_col)

df['Order Date'] = pd.to_datetime(df['Order Date'], format = '%m%d%y')

df['Order Number'] = pd.to_numeric(df['Order Number'])

df['Line Number'] = pd.to_numeric(df['Line Number'])

df['Quantity'] = pd.to_numeric(df['Quantity'])

#df['BookingDate'] = pd.to_datetime(df['BookingDate'], format = '%m%d%y') this one doens't convert, probably because text format of cells
