/*
    A Linking List for C++
    Copyright (©) 2023  Dream_Sunny

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
    USA
*/
//version 1.0.0.2
#pragma once
#pragma region Advance//Advance : Enable function [Use Define]
#define LinkList_Enable_Carray_Constructor_Function
//#define Linked_List_Use_C_exception
#pragma endregion Advance
#include <vector>
#ifndef Linked_List_Use_C_exception
#include <stdexcept>
#endif
template <class T> class LinkedListItem
{
private:
	T* _This;
	T* _Last;
	T* _Next;
public:
	inline ~LinkedListItem()
	{
		delete this->_This;
		this->_This = nullptr;
		this-> _Next = nullptr;
		this->_Last = nullptr;
	}
	inline LinkedListItem(T* THis, T* LAst =nullptr, T* NExt=nullptr) :_Next(NExt),_Last(LAst)
	{
		if (THis == nullptr) 
		{
			#ifdef Linked_List_Use_C_exception
			throw "Creation Failed : First parameter is null pointer";
			#endif
			#ifndef Linked_List_Use_C_exception
			throw std::invalid_argument("Creation Failed : First parameter is null pointer");
			#endif
		}
		this->_This = THis;
	}
	inline LinkedListItem()
	{
		this->_This = nullptr;
		this->_Next = nullptr;
		this->_Last = nullptr;
	}
	inline LinkedListItem(LinkedListItem<T>& others,const bool& CreateNew=true)
	{
		if(!CreateNew)
		{
			this->_This = others._This;
			this->_Next = others._Next;
			this->_Last = others._Last;
		}
		this->_This = new T(*others._This);
		this->_Next = nullptr;
		this->_Last = nullptr;
	}
	inline T Next() const 
	{
		return *this->_Next;
	}
	inline T Last() const 
	{
		return *this->_Last;
	}
	inline T This() const
	{
		return *this->_This;
	}
	inline T* ThisPtr()
	{
		return this->_This;
	}
	inline T* LastPtr()
	{
		return this->_Last;
	}
	inline T* NextPtr()
	{
		return this->_Next;
	}
	inline void ThisPtr(T* THis)
	{
		this->_This = THis;
	}
	inline void LastPtr(T* LAst)
	{
		this->_Last = LAst;
	}
	inline void NextPtr(T* NExt)
	{
		this->_Next = NExt;
	}
	inline T& ThisRef()
	{
		return *this->_This;
	}
	inline T& LastRef()
	{
		return *this->_Last;
	}
	inline T& NextRef()
	{
		return *this->_Next;
	}
	inline bool operator== (const T* right) const
	{
		return this->_This == right;
	}
	inline bool Equal(const T& Right) const
	{
		return *this->_This == Right;
	}
	LinkedListItem(LinkedListItem<T>* other) noexcept
	{
	    _This = other->_This;
 	   _Next = other->_Next;
	    _Last = other->_Last;
	    other->_This = nullptr;
	    other->_Next = nullptr;
	    other->_Last = nullptr;
	}
	LinkedListItem<T>& operator=(LinkedListItem<T>* other) noexcept
	{
	    if (this != &other) {
	        delete _This;
	        _This = other->_This;
	        _Next = other->_Next;
	        _Last = other->_Last;
	        other->_This = nullptr;
	        other->_Next = nullptr;
	        other->_Last = nullptr;
	    }
	    return *this;
	}
	LinkedListItem(LinkedListItem<T>& other)
	{
	    _This = other->_This;
 	   _Next = other->_Next;
	    _Last = other->_Last;
	}
	LinkedListItem<T>& operator=(LinkedListItem<T>& other)
	{
	    if (this != &other) {
	        delete _This;
	        _This = other->_This;
	        _Next = other->_Next;
	        _Last = other->_Last;
	    }
	    return *this;
	}
};

template <class Class, class IAllocator = unsigned long long int> class LinkList
{
public:
	~LinkList()
	{
		for (IAllocator i = 0; i < Length(); i++)
		{
			if(_Array->operator[](i) == nullptr) continue;
			delete _Array->operator[](i);
			_Array->operator[](i) = nullptr;
		}
		delete _Array;
		_Array = nullptr;
	}
	LinkList():_Array(new std::vector<LinkedListItem<Class>*>()){}
	LinkList(LinkList<Class,IAllocator>& others,const bool& CreateNew=true)
	{
		if(!CreateNew) _Array=others._Array;
		if(others .Length() == 0) 
		{
			#ifdef Linked_List_Use_C_exception
			throw "Creation Failed:parameter's Length is 0";
			#endif
			#ifndef Linked_List_Use_C_exception
			throw std::invalid_argument("Creation Failed:parameter's Length is 0");
			#endif
		}
		_Array = new std::vector<LinkedListItem<Class>*>(others.Length());
		for (IAllocator i = 0; i < others.Length(); i++)
		{
			_Array->push_back(new LinkedListItem<Class>(*others._Array->operator[](i),true));
		}
		Collect();
	}
	#ifdef LinkList_Enable_Carray_Constructor_Function
	LinkList(Class Carray[],IAllocator len)
	{
		if(len == 0) 
		{
			#ifdef Linked_List_Use_C_exception
			throw "Creation Failed:parameter's Length is 0";
			#endif
			#ifndef Linked_List_Use_C_exception
			throw std::invalid_argument("Creation Failed:parameter's Length is 0");
			#endif
		}
		_Array = new std::vector<LinkedListItem<Class>*>(len);
		for (IAllocator i = 0; i < len ; i++)
		{
			_Array->operator[](i)=new LinkedListItem<Class>(&Carray[i]);
		}
		Collect();
	}
	#endif
	LinkList(std::vector<Class>& Vector)
	{
		if(Vector.size() == 0) 
		{
			#ifdef Linked_List_Use_C_exception
			throw "Creation Failed:parameter's Length is 0"; 
			#endif
			#ifndef Linked_List_Use_C_exception
			throw std::invalid_argument("Creation Failed:parameter's Length is 0"); 
			#endif
		}
		_Array = new std::vector<LinkedListItem<Class>*>(Vector.size());
		for (IAllocator i = 0; i < Vector.size() ; i++)
		{
			_Array->operator[](i)=new LinkedListItem<Class>(&Vector[i]);
		}
		Collect();
	}
	inline IAllocator Length() const {return _Array->size();}
	void Collect()
	{
		EraseClear();
		IAllocator len=Length();
		if(len == 1 || len == 0) return;
		_Array->operator[](0)->NextPtr(_Array->operator[](1)->ThisPtr());
		_Array->operator[](0)->LastPtr(_Array->operator[](len-1)->ThisPtr());
		for (IAllocator i = 1; i < len-1; i++)
		{
			_Array->operator[](i)->NextPtr(_Array->operator[](i+1)->ThisPtr());
			_Array->operator[](i)->LastPtr(_Array->operator[](i-1)->ThisPtr());
		}
		_Array->operator[](len -1)->NextPtr(_Array->operator[](0)->ThisPtr());
		_Array->operator[](len -1)->LastPtr(_Array->operator[](len-2)->ThisPtr());
	}
	Class&  operator[](const IAllocator& index)
	{
		if(index>=Length()) 
		{
			#ifdef Linked_List_Use_C_exception
			throw "Out of index!";
			#endif
			#ifndef Linked_List_Use_C_exception
			throw std::runtime_error("Out of index!");
			#endif
		}
		return _Array->operator[](index)->ThisRef();
	}
	LinkedListItem<Class>& GetIndexItem(IAllocator& index)
	{
		if(index>=Length()) 
		{
			#ifdef Linked_List_Use_C_exception
			throw "Out of index!";
			#endif
			#ifndef Linked_List_Use_C_exception
			throw std::runtime_error("Out of index!");
			#endif
		}
		return &_Array->operator[](index);
	}
	Class& operator[](const Class& Item)
	{
		for (IAllocator i = 0; i < Length(); i++)
		{
			if (_Array->operator[](i)->This() == Item) return _Array->operator[](i)->ThisRef();
		}
		#ifdef Linked_List_Use_C_exception
		throw "Item Not Found!";		
		#endif
		#ifndef Linked_List_Use_C_exception
		throw std::runtime_error("Item Not Found!");		
		#endif
	}

	void Push_Back(const Class& Item)
	{
		_Array->push_back(new LinkedListItem<Class>(new Class(Item)));
		Collect();
	}
	void Pop_Back()
	{
		delete _Array->operator[](_Array->size()-1);
		_Array->operator[](_Array->size()-1)=nullptr;
		_Array->pop_back();
		Collect();
	}
	IAllocator FindFirstof(const Class& Item)
	{
		for (IAllocator i = 0; i < Length(); i++)
		{
			if (_Array->operator[](i)->Equal(Item)) return i;
		}
		#ifdef Linked_List_Use_C_exception
		throw "Item not in here";
		#endif
		#ifndef Linked_List_Use_C_exception
		throw std::runtime_error("Item not in here");
		#endif
	}
	IAllocator FindLastof(Class& Item)
	{
		for (int i = Length() - 1; i >= 0; i--)
		{
			if (_Array->operator[](i)->Equal(Item)) return i;
		}
		#ifdef Linked_List_Use_C_exception
		throw "Item not in here";
		#endif
		#ifndef Linked_List_Use_C_exception
		throw std::runtime_error("Item not in here");
		#endif
	}
	void InsertAtIndexBack(const IAllocator& index,const Class& Item)
	{
		_Array->emplace(_Array->begin()+index+1,new Class(Item));
	}
	void InsertAtIndexBefore(IAllocator& index,Class& Item)
	{
		_Array->emplace(_Array->begin()+index,new Class(Item));
	}
	void DeleteAt(const IAllocator& DeleteIndex)
	{
		_Array->erase(_Array->begin()+DeleteIndex);
		Collect();
	}
	void EraseClear()
	{
		for (IAllocator i = 0; i < _Array->size(); i++)
		{
			if(_Array->operator[](i) == nullptr) _Array->erase(_Array->begin() + i);
		}
	}
	void Merging(LinkList<Class,IAllocator>& others)
	{
		_Array->insert(_Array->end(),others._Array->begin(),others._Array->end());
		Collect();
	}
	LinkList<Class,IAllocator> Concatenate(LinkList<Class,IAllocator>& other)
	{
		std::vector<Class> tmp =std::vector<Class>(Length()+other.Length());
		for (IAllocator i = 0; i < Length(); i++)
		{
			tmp->push_back(*_Array->operator[](i));
		}
		for (IAllocator i = 0; i < other.Length(); i++)
		{
			tmp->push_back(other[i]);
		}
		return LinkList<Class,IAllocator>(tmp);
	}
	LinkList<Class,IAllocator>* ConcatenatePointer(LinkList<Class,IAllocator>& other)
	{
		std::vector<Class>* tmp =new std::vector<Class>(Length()+other.Length());
		for (IAllocator i = 0; i < Length(); i++)
		{
			tmp->push_back(*_Array->operator[](i));
		}
		for (IAllocator i = 0; i < other.Length(); i++)
		{	
			tmp->push_back(other[i]);
		}
		LinkList<Class,IAllocator>* tmp2=new LinkList<Class,IAllocator>(tmp);
		delete tmp;
		return tmp2;
	}
	class Iterator {
	private:
	    std::vector<LinkedListItem<Class>*>* _items;
	    size_t _currentIndex;
    
	public:
	    Iterator(std::vector<LinkedListItem<Class>*>* items, size_t currentIndex) : _items(items), _currentIndex(currentIndex) {}
	    Iterator& operator++() 
	    {
	        if (_currentIndex < _items->size()) 
			{
	            _currentIndex++;
	        }
	        return *this;
	    }
	    Iterator& operator--() 
	    {
	        if (_currentIndex > 0) {
	            _currentIndex--;
	        }
	        return *this;
	    }
	    Class& operator*() 
	    {
	        return (*_items)[_currentIndex]->ThisRef();
	    }
	    Class* operator->() 
	    {
	        return (*_items)[_currentIndex]->ThisPtr();
	    }
	    bool operator==(const Iterator& other) const 
	    {
	        return _currentIndex == other._currentIndex;
	    }
	    bool operator!=(const Iterator& other) const 
	    {
	        return _currentIndex != other._currentIndex;
	    }
	    Iterator& operator=(const Iterator& other) 
	    {
	        _items = other._items;
	        _currentIndex = other._currentIndex;
	        return *this;
	    }
	};
	Iterator begin() const
	{
	    return Iterator(_Array,0);
	}

	Iterator end() const
	{
 	   return Iterator(_Array,Length());
	}
	LinkList(LinkList<Class, IAllocator>* other) 
	{
	    _Array = other->_Array;
	    other->_Array = nullptr;
	}
	LinkList<Class, IAllocator>& operator=(LinkList<Class, IAllocator>* other) 
	{
	    if (this != &other) {
	        delete _Array;
	        _Array = other->_Array;
	        other->_Array = nullptr;
	    }
	    return *this;
	}
	LinkList<Class, IAllocator>& operator=(LinkList<Class, IAllocator>& other) 
	{
	    if (this != *other) {
	        delete _Array;
	        _Array=new std::vector<LinkedListItem<Class>*>(other->_Array);
	    }
	    return *this;
	}
private:
	std::vector<LinkedListItem<Class>*>* _Array=nullptr;
};
