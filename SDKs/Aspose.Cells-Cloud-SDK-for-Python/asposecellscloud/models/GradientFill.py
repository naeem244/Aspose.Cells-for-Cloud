#!/usr/bin/env python

class GradientFill(object):
    """NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually."""


    def __init__(self):
        """
        Attributes:
          swaggerTypes (dict): The key is attribute name and the value is attribute type.
          attributeMap (dict): The key is attribute name and the value is json key in definition.
        """
        self.swaggerTypes = {
            'FillType': 'str',
            'DirectionType': 'str',
            'Angle': 'float',
            'GradientStops': 'list[GradientFillStop]'

        }

        self.attributeMap = {
            'FillType': 'FillType','DirectionType': 'DirectionType','Angle': 'Angle','GradientStops': 'GradientStops'}       

        self.FillType = None # str
        self.DirectionType = None # str
        self.Angle = None # float
        self.GradientStops = None # list[GradientFillStop]
        
