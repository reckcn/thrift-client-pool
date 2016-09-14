﻿namespace CommonPool2.impl
{
    public class GenericObjectPoolConfig:BaseObjectPoolConfig
    {
         /**
     * The default value for the {@code maxTotal} configuration attribute.
     * @see GenericObjectPool#getMaxTotal()
     */
    public static  int DEFAULT_MAX_TOTAL = 8;

    /**
     * The default value for the {@code maxIdle} configuration attribute.
     * @see GenericObjectPool#getMaxIdle()
     */
    public static  int DEFAULT_MAX_IDLE = 8;

    /**
     * The default value for the {@code minIdle} configuration attribute.
     * @see GenericObjectPool#getMinIdle()
     */
    public static  int DEFAULT_MIN_IDLE = 0;


    private int maxTotal = DEFAULT_MAX_TOTAL;

    private int maxIdle = DEFAULT_MAX_IDLE;

    private int minIdle = DEFAULT_MIN_IDLE;

    /**
     * Get the value for the {@code maxTotal} configuration attribute
     * for pools created with this configuration instance.
     *
     * @return  The current setting of {@code maxTotal} for this
     *          configuration instance
     *
     * @see GenericObjectPool#getMaxTotal()
     */
    public int GetMaxTotal() {
        return maxTotal;
    }

    /**
     * Set the value for the {@code maxTotal} configuration attribute for
     * pools created with this configuration instance.
     *
     * @param maxTotal The new setting of {@code maxTotal}
     *        for this configuration instance
     *
     * @see GenericObjectPool#setMaxTotal(int)
     */
    public void setMaxTotal(int maxTotal) {
        this.maxTotal = maxTotal;
    }


    /**
     * Get the value for the {@code maxIdle} configuration attribute
     * for pools created with this configuration instance.
     *
     * @return  The current setting of {@code maxIdle} for this
     *          configuration instance
     *
     * @see GenericObjectPool#getMaxIdle()
     */
    public int GetMaxIdle() {
        return maxIdle;
    }

    /**
     * Set the value for the {@code maxIdle} configuration attribute for
     * pools created with this configuration instance.
     *
     * @param maxIdle The new setting of {@code maxIdle}
     *        for this configuration instance
     *
     * @see GenericObjectPool#setMaxIdle(int)
     */
    public void SetMaxIdle(int maxIdle) {
        this.maxIdle = maxIdle;
    }


    /**
     * Get the value for the {@code minIdle} configuration attribute
     * for pools created with this configuration instance.
     *
     * @return  The current setting of {@code minIdle} for this
     *          configuration instance
     *
     * @see GenericObjectPool#getMinIdle()
     */
    public int GetMinIdle() {
        return minIdle;
    }

    /**
     * Set the value for the {@code minIdle} configuration attribute for
     * pools created with this configuration instance.
     *
     * @param minIdle The new setting of {@code minIdle}
     *        for this configuration instance
     *
     * @see GenericObjectPool#setMinIdle(int)
     */
    public void SetMinIdle(int minIdle) {
        this.minIdle = minIdle;
    }
        public override object Clone()
        {
            throw new System.NotImplementedException();
        }
    }
}