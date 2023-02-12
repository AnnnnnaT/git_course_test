all_contacts = []

menu_show = [
    'Считать файл', #read_book
    'Сохранить файл', #save_file
    'Показать все контакты', #show_all
    'Найти контакт', #find_contact
    'Создать контакт', #create_contact, add_contact
    'Изменить контакт', #change_contact
    'Удалить контакт', #delete_contact
    'Выход', #exit
]

def show_menu():
    print('')
    print('ГЛАВНОЕ МЕНЮ\n')
    menu = []
    for i in range(len(menu_show)):
        menu.append(f'{i + 1}| {menu_show[i]}')
    print(f' {menu[0]}             {menu[1]}\n {menu[2]}    {menu[3]}\n {menu[4]}          {menu[5]}\n {menu[6]}          {menu[7]}\n')

def get_db():
    return all_contacts

def create_contact():
    new_contact = {'Lastname':input('Введите фамилию: \n'),
                'Firstname': input('Введите имя: \n'), 'phone': input('Введите номер телефона: \n'),
                'Comment':input('Введите комментарий: \n')}
    return new_contact

def add_contact(new_contact):
   all_contacts.append(new_contact)
   return all_contacts

def save_new_book(path, new_contact):
    contact = ''
    if len(all_contacts) == 1:
        contact = ';'.join(new_contact.values())
    elif len(all_contacts) > 1:
        contact = ';'.join(new_contact.values())
        contact = '\n' + contact
    with open(path, 'a', encoding='UTF-8') as data:
        data.write(contact)


def read_book():
    global all_contacts
    with open('data.txt', 'r', encoding='UTF-8') as data:
        data = data.readlines()
        for line in data:            
            contact = line.strip().split('|')
            id = []
            for i in  contact[0]:
                id.append(i)
            info = contact[1].split("--")
            all_contacts = dict(zip(id,info))
            

def show_all():
     with open ('data.txt', 'r', encoding = 'utf-8') as data:
        data.readlines
        for line in data:
            print(line)

def change_contact(change):
    if change in range(len(all_contacts)):
        print(
        f'{all_contacts[change - 1]["Lastname"]} '
        f'{all_contacts[change - 1]["Firstname"]} '
        f'{all_contacts[change - 1]["phone"]} '
        f'{all_contacts[change - 1]["Comment"]}:\n')
        changed_contact = {'id': change,
                        'Lastname': input('\tФамилия: '),
                        'Firstname': input('\tИмя: '),
                        'phone': input('\tНомер телефона: '),
                        'Comment': input('\tКомментарий: ')}
        all_contacts.append(changed_contact)
        return all_contacts


def delete_contact():
    show_all()
    deleting = input('Под каким номером удалить контакт? ')
    if deleting in range(len(all_contacts)):
        all_contacts.pop(deleting - 1)
    return all_contacts
    
# def find_contact(find_choice: tuple):

def found_contacts(find_choice: tuple) -> list:
    """
    Поиск контакта в списке контактов.
    :param find_choice: кортеж: критерий поиска и данные для поиска.
    :return: список контактов.
    """

    def find() -> list:
        """Внутрення функция поиска для однотипных запросов, исключающая повторение кода.
        :rtype: object
        """
        keys = ['Lastname', 'Firstname', 'Lastname_firstname', 'phone', 'ID']
        found: list = []
        for value in all_contacts:
            if find_choice[1].lower() == value[keys[find_choice[0] - 1]].lower():
                found.append(value)
        return found

    match find_choice[0]:
        case 1:
            new_found: list = find()
            return new_found
        case 2:
            new_found: list = find()
            return new_found
        case 3:
            new_found: list = []
            find = list(find_choice[1].lower().split())
            if len(find) == 1:
                return new_found
            if len(find) == 2:
                for item in all_contacts:
                    if find[0] == item['Lastname'].lower() and \
                            find[1] == item['Firstname'].lower():
                        new_found.append(item)
                return new_found
        case 4:
            new_found: list = find()
            return new_found
        case 5:
            new_found: list = find()
            return new_found

show_menu()