from django.db import models

from django.db import models

# Create your models here.


class SingletonModel (models.Model):

    def save(self, *args, **kwargs):
        self.pk = 1

        super().save(*args, **kwargs)


class Settings(SingletonModel):

    hours = models.IntegerField()
    days = models.CharField(max_length=30)