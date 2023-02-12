import model
import view
import sys

def exit_program():
        sys.exit()


def start():
    model.show_menu()
    while True:
        command = view.user_choice()
        handler(command)

def handler(command):
    match command:
        case 1:
            model.read_book()
        case 2:
             model.save_book() 
        case 3:
            model.show_all()          
        case 4:
             found_contact = model.found_contacts(view.find_choice())
             view.show_contact(found_contact)
            
        case 5:
            model.create_contact()
        
        case 6:
            change = view.change(model.get_db())
            if change is not None:
                model.change_contact(change)
        
        case 7:
            model.delete_contact()
        case 8:
            exit_program()
