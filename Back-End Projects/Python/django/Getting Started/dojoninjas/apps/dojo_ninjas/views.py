# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.shortcuts import render,redirect,HttpResponse

def index(request):
    response = "hey"
    return HttpResponse(response)
# Create your views here.
