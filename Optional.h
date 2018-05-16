template<typename T> class Optional
{
public:

    Optional()                                                                               {}
    Optional(T value)                    : value(value), valid(true)                         {}
    Optional(const Optional<T> &other)   : value(other.value), valid(other.valid)            {}
    Optional(const Optional<T> &&other)  : value(std::move(other.value)), valid(other.valid) {}
    
    Optional &operator=(const T &val)               { valid = true;      value = val;                  return *this; }
    Optional &operator=(const Optional &num)        { valid = num.valid; value = num.value;            return *this; }
    Optional &operator=(Optional &&num)             { valid = num.valid; value = std::move(num.value); return *this; }

    bool operator==(const Optional<T> &num)   const { return valid == num.valid && (!valid || value == num.value); }
    bool operator==(const T &num)             const { return valid && value == num;                                }
		 
    bool operator!=(const Optional<T> &num)   const { return !operator==(num); }
    bool operator!=(const T &num)             const { return !operator==(num); }
    
    bool isValid() const { return valid; }

    operator const T&()   const { assert(valid); return  value; }
    const T *operator->() const { assert(valid); return &value; }
    const T &operator* () const { assert(valid); return  value; }

private:
    T       value = {};
    bool    valid = {};
};