def user_choice():
    a = int(input("Выберете дейсьтвие: "))
    return a


def change():
    a = int(input('Контакт под каким номером хотите изменить? '))
    return a
def find_choice() -> tuple:
    """
    Функция выбора критерия поиска контакта и значения для поиска.
    :return: номер критерия, значение для поиска.
    """
    print('\nКритерии поиска:')
    find_list = [
        'Фамилия',
        'Имя',
        'Фамилия и имя',
        'Номер телефона',
        'ID контакта (численное значение)'
    ]

    for i, value in enumerate(find_list, start=1):
        print(f'\t{i}. {value}')
    print()

    while True:
        try:
            user_choice = int(input('Выберите номер критерия поиска: '))
            if user_choice < 1 or user_choice > 5:
                print('\nВведите номер команды от 1 до 4.\n')
            else:
                find_data = input('Введите данные для поиска в соответствии с критерием: ')
                if user_choice < 5:
                    return user_choice, find_data
                if user_choice == 5 and find_data.isdigit():
                    find_data = 'id_' + str(find_data)
                    return user_choice, find_data
                if user_choice == 5 and not find_data.isdigit():
                    print('\nНекорректный ID! Необходимо вводить только число ID. '
                          'Вы можете изменить критерий поиска.\n')
        except ValueError:
            print('\nНекорректный ввод! Введите номер команды.\n')


def show_contact(contacts):
    
    if contacts:
        for i, item in enumerate(contacts):
            print(f'\t{i + 1}', end=' ')
            print(f'{" ".join(item.values())}')
    else:
        print('\tКонтакт не найден!\n')
