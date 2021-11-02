import pyautogui
pyautogui.FAILSAFE = True
pyautogui.sleep(5)
pyautogui.moveTo(245, 251, duration=0.2)
for i in range(100):
    pyautogui.dragTo(553, 551, duration=0.14)
    pyautogui.dragTo(245, 251, duration=0.14)
#pyautogui.click(245,251)
#pyautogui.click(553,551)
#pyautogui.sleep(5)
#pyautogui.alert(pyautogui.position())
