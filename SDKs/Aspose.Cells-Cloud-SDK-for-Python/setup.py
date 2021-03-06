__author__ = 'farooq.sheikh'

from setuptools import setup, find_packages

setup(
    name = 'asposecellscloud',
    packages = find_packages(),
    version = '1.0',
    description = 'Aspose.Cells Cloud SDK for Python allows you to use Aspose.Cells APIs in your Python applications',
    author='Farooq Sheikh',
    author_email='farooq.sheikh@aspose.com',
    url='https://github.com/asposecells/Aspose_Cells_Cloud/tree/master/SDKs/Aspose.Cells_Cloud_SDK_For_Python',
    install_requires=[
        'asposestoragecloud',
    ],
    classifiers=[
        'Programming Language :: Python',
        'Programming Language :: Python :: 2',
        'License :: OSI Approved :: MIT License',
        'Operating System :: OS Independent'
    ]
)
