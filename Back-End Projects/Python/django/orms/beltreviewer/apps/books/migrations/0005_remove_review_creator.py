# -*- coding: utf-8 -*-
# Generated by Django 1.11.13 on 2018-05-21 19:02
from __future__ import unicode_literals

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('books', '0004_auto_20180521_1159'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='review',
            name='creator',
        ),
    ]
