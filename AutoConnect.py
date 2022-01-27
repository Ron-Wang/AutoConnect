# -*- coding: utf-8 -*-
"""
Created on Thu Jan 27 16:27:09 2022

@author: ron wang
"""

from selenium import webdriver
from selenium.webdriver.common.by import By
import time

while 1:
    browser = webdriver.Chrome('C:\Program Files\Google\Chrome\Application\chromedriver.exe')  # 实例化对象
    url = 'https://login.tsinghua.edu.cn'
    browser.get(url)
    windows = browser.window_handles
    browser.switch_to.window(windows[-1])
    currentPageUrl = browser.current_url
    if('succeed' in currentPageUrl):
        pass
    else:
        newUrl = 'https://auth4.tsinghua.edu.cn/srun_portal_pc.php?ac_id=' + currentPageUrl.split('_')[1].split('.')[0] + '&'
        browser.get(newUrl)
        browser.find_element(By.ID, 'username').send_keys('*********')  # 找到账号框并输入账号
        browser.find_element(By.ID, 'password').send_keys('*********')  # 找到密码框并输入密码
        browser.find_element(By.ID, 'connect').click()  # 找到登陆按钮并点击
    time.sleep(3)
    browser.quit()
    time.sleep(600)

