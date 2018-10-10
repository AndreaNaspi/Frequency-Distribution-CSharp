using System;

public class Student
{

    // Private fields
    private String gender;
    private int age;
    private int weight;
    private int height;

    // Class representing the Student with gender (String), age, weight, height
    public Student(String gender, int age, int weight, int height)
    {
        this.gender = gender;
        this.age = age;
        this.weight = weight;
        this.height = height;
    }

    // Gender getter
    public String getGender()
    {
        return gender;
    }

    // Age getter
    public int getAge()
    {
        return age;
    }

    // Weight getter
    public int getWeight()
    {
        return weight;
    }

    // Height getter
    public int getHeight()
    {
        return height;
    }

    // Gender setter
    public void setGender(String gender)
    {
        this.gender = gender;
    }

    // Age setter
    public void setAge(int age)
    {
        this.age = age;
    }

    // Weight setter
    public void setWeight(int weight)
    {
        this.weight = weight;
    }

    // Height setter
    public void setHeight(int height)
    {
        this.height = height;
    }
}