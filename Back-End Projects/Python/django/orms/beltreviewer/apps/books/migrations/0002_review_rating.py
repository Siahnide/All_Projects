# -*- coding: utf-8 -*-
# Generated by Django 1.11.13 on 2018-05-20 21:35
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('books', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='review',
            name='rating',
            field=models.CharField(default=2, max_length=255),
            preserve_default=False,
        ),
    ]