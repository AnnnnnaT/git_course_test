# Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
x1, y1 = float(input('Введите координату x точки A:' )), float(input('Введите координату y точки A:' ))
x2, y2 = float(input('Введите координату x B:' )), float(input('Введите координату y точки B:' ))
d = round(((x2-x1)**2+(y2-y1)**2)**(0.5),2)
print(f'Расстояние между точками A{x1,y1} и B{x2,y2} в 2D пространстве - {d}')