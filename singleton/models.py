from django.db import models

from django.db import models

# Create your models here.


# involves a single class which is responsible to create an object while making sure that only single object gets created

class SingletonModel (models.Model):

    def save(self, *args, **kwargs):
        self.pk = 1 # Indicates that the field will be always replaced by the same id (1)

        super().save(*args, **kwargs)

# Values for the database

class Settings(SingletonModel):

    drone_usage_hours_by_day = models.IntegerField()
    drone_usage_days = models.CharField(max_length=30)