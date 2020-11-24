#добавление нужных библиотек
import pygame
import random as r
import time
from pygame.locals import*
import math

#запуск/переменные, отвечающие за цвета, позицию и размер дисков

pygame.init()

#global display_width
display_width = 1024
#global display_height
display_height = 576
#global display_center
display_center = (display_width / 2, display_height / 2)

display = pygame.display.set_mode([display_width, display_height], RESIZABLE)


#цвета ниже сохранены как переменны, с помощью модели RGB

black = (0, 0, 0)
white = (255, 255, 255)
red = (255, 0, 0)
blue = (0, 0, 255)

disc_width = display_width * 0.22
disc_height = display_height * 0.055
fx = display_width * 0.06
poschange = math.floor(display_height * 0.055)
widchange = display_width * 0.0366

f_list = []
s_list = []
th_list = []

#название окна

pygame.display.set_caption('Hanoi Towers')

clock = pygame.time.Clock()

#функция стартового окна

def start_menu():
	f_list.clear()
	s_list.clear()
	th_list.clear()

	global display_width
	global display_height
	global display_center
	global disc_width
	global disc_height
	global fx
	global poschange
	global widchange
	
	display.fill(white)
	printtext_large('Hanoi Towers', display_center, black)
	printtext_small('Choose level of difficulty', (display_width / 2, display_height / 2 + 100), black)
	printtext_small('\'3\' - EASY  \'4\' - MEDIUM  \'5\' - HARD', (display_width / 2, display_height / 2 + 150), black)
	while True:
		for event in pygame.event.get():
			if event.type == pygame.QUIT:
				pygame.quit()
				quit()
			
			if event.type == pygame.VIDEORESIZE:
				screen = pygame.display.set_mode((event.w, event.h), RESIZABLE)
				screen.fill(white)
				resize_scale_width = event.w / display_width
				resize_scale_height = event.h / display_height
				display_width = event.w
				display_height = event.h
				display_center = (display_width / 2, display_height / 2)
				disc_width = display_width * 0.22
				disc_height = disc_height * resize_scale_height
				fx = display_width * 0.06
				poschange = math.floor(disc_height)
				widchange = disc_width * 0.1663
				

				display.fill(white)
				printtext_large('Hanoi Towers', display_center, black)
				printtext_small('Choose level of difficulty', (display_width / 2, display_height / 2 + 100), black)
				printtext_small('\'3\' - EASY  \'4\' - MEDIUM  \'5\' - HARD', (display_width / 2, display_height / 2 + 150), black)

			if event.type == pygame.KEYDOWN:
				s = pygame.key.name(event.key)
				global n
				if (s == '3') or (s == '4') or (s == '5'):
					n = int(s)
					gameloop()

#функция объектов вывода текста

def text_objects(text, font, cvet):
	textsurface = font.render(text, True, cvet)
	return textsurface, textsurface.get_rect()

#вывод текста большого шрифта

def printtext_large(text, position, color):
	fontsize = pygame.font.SysFont("Calibri", 115)
	textsurf, textrect = text_objects(text, fontsize, color)
	textrect.center = (position)
	display.blit(textsurf, textrect)
	pygame.display.update()

#вывод текста меньшего шрифта

def printtext_small(text, position, color):
	fontsize = pygame.font.SysFont("Calibri", 25)
	textsurf, textrect = text_objects(text, fontsize, color)
	textrect.center = (position)
	display.blit(textsurf, textrect)
	pygame.display.update()

#рисование стержней
def needle(nx, ny, nwid, nhite, color):
	pygame.draw.rect(display, color, [nx, ny, nwid, nhite])

#инструкция для решения

def solution(m, first, second, third):
	if (m > 0):
		solution(m - 1, first, third, second)
		print(first, third)
		solution(m - 1, second, first, third)

#главная функция

def gameloop():
	global display_width
	global display_height
	global display_center
	global disc_width
	global disc_height
	global fx
	global poschange
	global widchange
	r_change = 0
	won = False

	disc_locations = [(fx, display_height - disc_height),
		  (fx + widchange / 2 * 1, display_height - disc_height - poschange),
		  (fx + widchange / 2 * 2, display_height - disc_height - poschange * 2),
		  (fx + widchange / 2 * 3, display_height - disc_height - poschange * 3),
		  (fx + widchange / 2 * 4, display_height - disc_height - poschange * 4),
		  (fx + widchange / 2 * 5, display_height - disc_height - poschange * 5),
		  (fx + widchange / 2 * 6, display_height - disc_height - poschange * 6),
		  (fx + widchange / 2 * 7, display_height - disc_height - poschange * 7),
		  (fx + widchange / 2 * 8, display_height - disc_height - poschange * 8)]

	display.fill(white)
	needle(display_width * 0.17, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
	needle(display_width * 0.5, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
	needle(display_width * 0.83, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)

	#задать первоначальное местонахождение дисков

	for i in range (0, n):
		randcolor = (r.randint(0, 255), r.randint(0, 255), r.randint(0, 255))
		disc = pygame.Surface((disc_width - r_change, disc_height))
		disc.fill(randcolor)
		f_list.append(disc)
		display.blit(f_list[i], disc_locations[i])
		r_change += poschange

	#цикл игры
	
	while not won:
		#условие завершения цикла
		if len(th_list) == n:
			time.sleep(1.5)
			won = True

		#управление событиями и изменение координат дисков
			
		for event in pygame.event.get():
			
			if event.type == pygame.QUIT:
				pygame.quit()
				quit()

			if event.type == pygame.VIDEORESIZE:
				screen = pygame.display.set_mode((event.w, event.h), RESIZABLE)
				screen.fill(white)
				resize_scale_width = event.w / display_width
				resize_scale_height = event.h / display_height
				display_width = event.w
				display_height = event.h
				display_center = (display_width / 2, display_height / 2)
				disc_height = disc_height * resize_scale_height
				fx = display_width * 0.06
				poschange = disc_height

				needle(event.w * 0.17, event.h * 0.333, event.w * 0.005, event.h * 0.666, black)
				needle(event.w * 0.5, event.h * 0.333, event.w * 0.005, event.h * 0.666, black)
				needle(event.w * 0.83, event.h * 0.333, event.w * 0.005, event.h * 0.666, black)

				if len(f_list):
					for i in range (0, len(f_list)):
						f_list[i] = pygame.transform.scale(f_list[i], (math.floor(f_list[i].get_width() * resize_scale_width), math.floor(f_list[i].get_height() * resize_scale_height)))
						poschange = f_list[i].get_height()
						display.blit(f_list[i], (event.w * 0.17 - f_list[i].get_width() / 2, event.h - disc_height - poschange * i))

				if len(s_list):
					for i in range (0, len(s_list)):
						s_list[i] = pygame.transform.scale(s_list[i], (math.floor(s_list[i].get_width() * resize_scale_width), math.floor(s_list[i].get_height() * resize_scale_height)))
						poschange = s_list[i].get_height()
						display.blit(s_list[i], (event.w * 0.50 - s_list[i].get_width() / 2, event.h - disc_height - poschange * i))

				if len(th_list):
					for i in range (0, len(th_list)):
						th_list[i] = pygame.transform.scale(th_list[i], (math.floor(th_list[i].get_width() * resize_scale_width), math.floor(th_list[i].get_height() * resize_scale_height)))
						poschange = th_list[i].get_height()
						display.blit(th_list[i], (event.w * 0.83 - th_list[i].get_width() / 2, event.h - disc_height - poschange * i))

			if event.type == pygame.KEYDOWN:

				#горячая клавиша помощи
				if event.key == pygame.K_1:
					current_needle = f_list

				if event.key == pygame.K_2:
					current_needle = s_list

				if event.key == pygame.K_3:
					current_needle = th_list

				if event.key == pygame.K_h:
					solution(n, 1, 2, 3)

				if event.key == pygame.K_DOWN:

					if (current_needle != s_list):
						if (len(current_needle) and not len(s_list)) or\
						   (len(current_needle) and len(s_list) and\
							s_list[len(s_list) - 1].get_width() > current_needle[len(current_needle) - 1].get_width()):
							
								s_list.append(current_needle[len(current_needle) - 1])
								current_needle.remove(current_needle[len(current_needle) - 1])

								display.fill(white)
								needle(display_width * 0.17, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								needle(display_width * 0.5, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								needle(display_width * 0.83, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								
								if len(f_list):
									for i in range (0, len(f_list)):
										display.blit(f_list[i], (display_width * 0.17 - f_list[i].get_width() / 2, display_height - disc_height - poschange * i))

								if len(s_list):
									for i in range (0, len(s_list)):
										display.blit(s_list[i], (display_width * 0.5 - s_list[i].get_width() / 2, display_height - disc_height - poschange * i))

								if len(th_list):
									for i in range (0, len(th_list)):
										display.blit(th_list[i], (display_width * 0.83 - th_list[i].get_width() / 2, display_height - disc_height - poschange * i))

				if event.key == pygame.K_RIGHT:

					if current_needle != th_list:
						if (len(current_needle) and not len(th_list)) or\
						   (len(current_needle) and len(th_list) and\
							th_list[len(th_list) - 1].get_width() > current_needle[len(current_needle) - 1].get_width()):
							
								th_list.append(current_needle[len(current_needle) - 1])
								current_needle.remove(current_needle[len(current_needle) - 1])

								display.fill(white)
								needle(display_width * 0.17, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								needle(display_width * 0.5, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								needle(display_width * 0.83, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)

								if len(f_list):
									for i in range (0, len(f_list)):
										display.blit(f_list[i], (display_width * 0.17 - f_list[i].get_width() / 2, display_height - disc_height - poschange * i))

								if len(th_list):
									for i in range (0, len(th_list)):
										display.blit(th_list[i], (display_width * 0.83 - th_list[i].get_width() / 2, display_height - disc_height - poschange * i))

								if len(s_list):
									for i in range (0, len(s_list)):
										display.blit(s_list[i], (display_width * 0.5 - s_list[i].get_width() / 2, display_height - disc_height - poschange * i))

				if event.key == pygame.K_LEFT:

					if (current_needle != f_list):
						if (len(current_needle) and not len(f_list)) or\
						   (len(current_needle) and len(f_list) and\
							f_list[len(f_list) - 1].get_width() > current_needle[len(current_needle) - 1].get_width()):
							
								display.fill(white)
								needle(display_width * 0.17, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								needle(display_width * 0.5, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								needle(display_width * 0.83, display_height * 0.333, display_width * 0.005, display_height * 0.666, black)
								f_list.append(current_needle[len(current_needle) - 1])
								current_needle.remove(current_needle[len(current_needle) - 1])

								if len(f_list):
									for i in range (0, len(f_list)):
										display.blit(f_list[i], (display_width * 0.17 - f_list[i].get_width() / 2, display_height - disc_height - poschange * i))

								if len(th_list):
									for i in range (0, len(th_list)):
										display.blit(th_list[i], (display_width * 0.83 - th_list[i].get_width() / 2, display_height - disc_height - poschange * i))

								if len(s_list):
									for i in range (0, len(s_list)):
										display.blit(s_list[i], (display_width * 0.5 - s_list[i].get_width() / 2, display_height - disc_height - poschange * i))

				

		#обновление окна и кадры в секунду       
		pygame.display.update()
		clock.tick(5)

	#победа

	display.fill(white)
	printtext_large('Congratulations!!!', display_center, randcolor)
	#printtext_small('', (display_width / 2, display_height / 2 + 100), randcolor)

	time.sleep(2)

	#перезапуск игры
			
	display.fill(white)
	printtext_large('RESTART?', display_center, randcolor)
	printtext_small('press Y to restart, to quit, press N', (display_width / 2, display_height / 2 + 100), randcolor)





	while True:        
		for event in pygame.event.get():
			
			if event.type == pygame.QUIT:
				pygame.quit()
				quit()
			
			if event.type == pygame.KEYDOWN:
				if event.key == pygame.K_y:
					start_menu()
				elif event.key == pygame.K_n:
					pygame.quit()
					quit()

start_menu()
#конец
pygame.quit()
quit()