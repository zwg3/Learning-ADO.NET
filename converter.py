import csv

#FILE DETAILS FAILED BANKS THAT WERE RESOLD SINCE 1ST OF OCTOBER 2000

INPUT_FILE = "banklist.csv"

with open(INPUT_FILE, 'r') as file:
    csv_reader = csv.DictReader(file)
    bank_list = [row for row in csv_reader]

#print(bank_list[0]['Bank Name'])